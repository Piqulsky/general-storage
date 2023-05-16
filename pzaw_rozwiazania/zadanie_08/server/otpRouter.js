const express = require('express')
const otpRouter = express.Router();

const { hotp } = require('node-otp')

let otps = [];

otpRouter.get("/", (req, res) => {
    console.log("GET/otp", req.query, req.session.id);
    let params = req.query;
    let otp = hotp({
        secret: req.session.id,
    });
    res.status(200).send(otp);
    otps.push(otp);
    console.log(otps);
    setTimeout(() => {
        otps = otps.filter(x => x != otp);
    }, 600000)
})

otpRouter.get("/check", (req, res) => {
    console.log("GET/otp/check", req.query, req.session.id);
    let params = req.query;
    if(otps.find(x => x == params.otp)){
        res.status(200).send("Logged");
    }
    else{
        res.status(401).send("Unauthorized");
    }
})

module.exports = { otpRouter }