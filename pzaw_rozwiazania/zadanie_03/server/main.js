const http = require('http');

const hostname = '127.0.0.1';
const port = 3000;

let data = {
    "users":[
        { firstName : "John", lastName : "Doe" },
        { firstName : "Anna", lastName : "Smith" },
        { firstName : "Peter", lastName : "Jones" },
    ],
};

const server = http.createServer((req, res) => {
  const url = req.url;
  const method = req.method;
  console.log(url, method);
  res.setHeader('Access-Control-Allow-Origin', '*');
  
  if(req.method == "OPTIONS"){
    res.statusCode = 200;
    res.setHeader('Access-Control-Allow-Methods', 'GET,POST,PATCH,PUT,DELETE,HEAD');
    res.end();
    return;
  }
  
  if(url === "/pzaw_zadanie_03" && method === "GET"){
    res.write(JSON.stringify(data));
    res.end();
  }
  else if(url === "/pzaw_zadanie_03" && method === "POST"){
    let chunks = [];
    req.on('data', (chunk) => {
      chunks.push(chunk);
    })
    req.on('end', () => {
      const body = JSON.parse(Buffer.concat(chunks).toString());
      data.users.push(body);
      res.end();
    })
  }
  else if(url === "/pzaw_zadanie_03" && method === "PUT"){
    let chunks = [];
    req.on('data', (chunk) => {
      chunks.push(chunk);
    })
    req.on('end', () => {
      const body = JSON.parse(Buffer.concat(chunks).toString());
      data.users[body.id-1] = {"firstName": body.firstName, "lastName": body.lastName};
      res.end();
    })
  }
  else if(url === "/pzaw_zadanie_03" && method === "DELETE"){
    let chunks = [];
    req.on('data', (chunk) => {
      chunks.push(chunk);
    })
    req.on('end', () => {
      const body = JSON.parse(Buffer.concat(chunks).toString());
      data.users.splice(body.id-1, 1);
      res.end();
    })
  }
  else{
    res.end();
  }
});

server.listen(port, hostname, () => {
  console.log(`Server running at http://${hostname}:${port}/`);
});