function getInputs() {
  const a = document.getElementById('num1').value.trim();
  const b = document.getElementById('num2').value.trim();

  if (a === '' || b === '') {
    alert('Please enter both numbers before performing an operation.');
    return null;
  }

  return { a: parseFloat(a), b: parseFloat(b) };
}

function showResult(expression, result) {
  const section = document.getElementById('result-section');
  const text = document.getElementById('result-text');
  text.textContent = `${expression} = ${result}`;
  section.classList.remove('d-none');
}

function calculate(operation) {
  const inputs = getInputs();
  if (!inputs) return;

  const { a, b } = inputs;
  let result, expression;

  switch (operation) {
    case 'add':
      result = a + b;
      expression = `${a} + ${b}`;
      break;

    case 'subtract':
      result = a - b;
      expression = `${a} - ${b}`;
      break;

    case 'multiply':
      result = a * b;
      expression = `${a} × ${b}`;
      break;

    case 'divide':
      if (b === 0) {
        alert('Division by zero is not allowed. Please enter a non-zero second number.');
        return;
      }
      result = (a / b).toFixed(2);
      expression = `${a} ÷ ${b}`;
      break;
  }

  showResult(expression, result);
}