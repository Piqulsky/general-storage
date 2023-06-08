const express = require('express')
const articlesRouter = express.Router();

const bcryptjs = require('bcryptjs');
const fs = require('fs');

const { Articles } = require('./sequelize/sequelize')

let data = require('./data.json');

articlesRouter.get("/", (req, res) => {
    console.log("GET/articles", req.query, req.session.id);
    console.log(data.sessions);
    if(data.sessions.find(x => x == req.session.id)){
        var articles = Articles.findAll();
        res.status(200).send(articles);
    }
    else
        res.status(400).send("No session")
})

module.exports = { articlesRouter }