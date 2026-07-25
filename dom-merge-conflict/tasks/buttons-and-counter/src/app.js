//increments the number in a node's text
function increment(node) {
  let current = node.textContent;
  node.textContent = Number(current) + 1;
}
function decrement(node) {
  let current = node.textContent;
  node.textContent = Number(current) - 1;
}

export function App() {
  const body = document.createElement("body");

  const header = document.createElement("header");
  header.innerHTML = `
        <h1>Number Counter</h1>
        <p>A simple counter. Press increment to increase the count or decrement to decrease the count.</p>
    `;
  body.appendChild(header);

  const main = document.createElement("main");
  main.innerHTML = `
        <p id="counter" data-testid="counter">0</p>
        <button id="increment">Increment</button>
        <button id="decrement">Decrement</button>
    `;
  body.appendChild(main);

  const buttonIncrement = body.querySelector("#increment");
  const buttonDecrement = body.querySelector("#decrement");
  const counter = body.querySelector("#counter");

  buttonIncrement.addEventListener("click", () => {
    increment(counter);
  });

  buttonDecrement.addEventListener("click", () => {
    decrement(counter);
  });

  return body;
}
