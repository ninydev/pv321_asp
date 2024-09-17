
import express from 'express';

const app = express();

app.get('/',
    (req, res) => {

    res.send('index');
});

app.get('/about', (req, res) => {
    res.send('about');
});

app.get('/contact', (req, res) => {
    res.send('contact');
});

app.listen(3030, 'localhost', () => {
    console.log("http://localhost:3030");
});