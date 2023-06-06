const http = require('http');
const port = 8080;

const data = require('./data.json');

const app = http.createServer((req, res) => {
    if(req.url == "/egz_ai"){
        res.setHeader('Access-Control-Allow-Origin', '*');
        res.write(JSON.stringify(data));
    }
    res.end();
});

app.listen(port, () => {
    console.log("App listening on: localhost:" + port);
});