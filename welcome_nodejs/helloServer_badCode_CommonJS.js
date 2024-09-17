require('http')
    .createServer((req, response) => {
        response.writeHead(200, {'Content-Type': 'text/plain'});
        response.end('Hello World!\n');
    })
    .listen(3000, '127.0.0.1', () => {
        console.log('Listening on http://127.0.0.1:3000');
    });
