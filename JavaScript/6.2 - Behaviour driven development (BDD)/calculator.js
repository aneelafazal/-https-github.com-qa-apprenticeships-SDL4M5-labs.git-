class Calculator {
    constructor() {
        this.answer = 0;
    }

    add(x, y) {
        this.answer = x + y;
    }

    getResult() {
        return this.answer;
    }
}

module.exports = Calculator;