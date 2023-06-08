const express = require('express');
const mainRouter = express.Router();
const { authenticateRouter } = require('./authenticateRouter');
const { otpRouter } = require('./otpRouter');
const { articlesRouter } = require('./articlesRouter');

mainRouter.use("/", authenticateRouter);
mainRouter.use("/otp", otpRouter);
mainRouter.use("/articles", articlesRouter);

module.exports = { mainRouter }