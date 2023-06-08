const express = require('express')
const app = express()
const port = 8080
const { mainRouter } = require('./api')

// Middlewares
const cors = require('cors');
const bodyParser = require('body-parser')
const expressSession = require('express-session')
const uuid = require('uuid')

app.use(cors({
  credentials: true,
  origin: true
}))
app.use(bodyParser.json());
app.use(expressSession({
  secret: "no troche xd",
  genid: uuid.v4
}))

app.use("/", mainRouter);

app.listen(port, () => {
  console.log(`Server listening on port ${port}`)
})