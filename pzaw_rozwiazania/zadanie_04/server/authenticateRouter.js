const express = require('express')
const authenticateRouter = express.Router();

const bcryptjs = require('bcryptjs');
const fs = require('fs');

const { Users } = require('./sequelize/sequelize')

let data = require('./data.json');

authenticateRouter.get("/", async (req, res) => {
    console.log("GET/", req.query, req.session.id);
    let params = req.query;
    const user = await Users.findOne({
        where: {
            username: params.username
          }
    })
    if(user){
        bcryptjs.compare(params.password, user.password, (err, result) => {
            if(result){
                data.sessions.push(req.session.id);
                res.status(200).send("Logged");
            }
            else
                res.status(400).send("Wrong credentials");
        })
    }
    else
        res.status(400).send("Wrong credentials");
})

authenticateRouter.get("/check", (req, res) => {
    console.log("GET/check", req.query, req.session.id);
    let params = req.query;
    if(data.sessions.find(x => x == req.session.id))
        res.status(200).send("Logged");
    else
        res.status(400).send("No session")
})

authenticateRouter.get("/users", (req, res) => {
    res.status(200).send(data.users);
})

authenticateRouter.get("/sessions", (req, res) => {
    res.status(200).send(data.sessions);
})

authenticateRouter.get("/articles", (req, res) => {
    console.log("GET/articles", req.query, req.session.id);
    console.log(data.sessions);
    if(data.sessions.find(x => x == req.session.id))
        res.status(200).send(data.articles);
    else
        res.status(400).send("No session")
})

authenticateRouter.post("/", async (req, res) => {
    console.log("POST/", req.body, req.session.id);
    let body = req.body;
    const user = await Users.findOne({
        where: {
            username: body.username
          }
    })
    if(!user){
        const newUser = await Users.create({username: body.username, password: bcryptjs.hashSync(body.password, 10), role: 0})
        data.sessions.push(req.session.id);
        res.status(201).send("Registered");
    }
    else{
        res.status(400).send("User exists");
    }
})

authenticateRouter.delete("/", (req, res) => {
    console.log("DELETE/", req.body, req.session.id);
    data.sessions = data.sessions.filter(x => x != req.session.id);
    if(!data.sessions.find(x => x == req.session.id))
        res.status(200).send(req.session.id);
})

module.exports = { authenticateRouter }