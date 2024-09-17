const http = require('http');




const server =
    http.createServer(
        (
                request, // Що прийшло
                response// Що я будую у відповідь
    )=> {

            console.log("URL: " + request.url);
            console.log("Method: " + request.method);

            switch (request.method) {
                case "POST":
                    break;
                case "GET":
                    let arrUrls = request.url.split('/');
                    switch (arrUrls[0]) {
                        case '/':
                            break;
                        case 'about':
                            break;
                        default:
                    }
                    break;
                default:
                    break;
            }

            response.writeHead(200, { 'Content-Type': 'text/plain' });

            let date = new Date(Date.now());

            response.end('Hello World!\n' + date.toLocaleString());
});





// запускает простой локальный HTTP-сервер на порту 3000
server.listen(3000, '127.0.0.1', () => {
    console.log('Listening on http://127.0.0.1:3000');
});
