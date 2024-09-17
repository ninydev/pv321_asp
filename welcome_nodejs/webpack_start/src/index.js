// Пример простого JavaScript-кода
function component() {
    const element = document.createElement('div');

    // Добавим текст в элемент
    element.innerHTML = 'Привет, Webpack!';

    return element;
}

// Добавляем созданный элемент в body
document.body.appendChild(component());