const path = require('path');

module.exports = {
    entry: './src/index.js', // Входной файл
    output: {
        filename: 'bundle.js', // Выходной файл
        path: path.resolve(__dirname, 'dist'), // Папка для сборки
    },
    mode: 'production', // Режим разработки или production
};