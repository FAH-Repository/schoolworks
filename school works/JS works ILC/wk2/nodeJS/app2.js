// while running can acess localhost:3000 in a browser, can add /api/courses too

const http = require('http');
const server = http.createServer((req, res) =>{
if (req.url === '/'){
res.write('Hello world');
res.end();
}

if(req.url === '/api/courses'){
res.write(JSON.stringify([1, 2, 3]));
res.end();
}
});

/*
const server = http.createServer();
server.on('connection', (socket) => {
console.log('new connection');
});
*/
server.listen(3000);

console.log('listening on port 3000...');
//^C to close in command line
