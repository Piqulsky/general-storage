const express = require('express');
const mainRouter = express.Router();
const { authenticateRouter } = require('./authenticateRouter');
const { otpRouter } = require('./otpRouter');

mainRouter.use("/", authenticateRouter);
mainRouter.use("/otp", otpRouter);

module.exports = { mainRouter }