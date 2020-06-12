import React, { useState } from "react";
import ReactDOM from "react-dom";
import './Styles/index.css'

function CalculatorWindow() {
  const [value, setValue] = useState(0);
  const [operation, setOperation] = useState();
  return (
    <div>
      <h1>Calculator</h1>
      <h3>Selected input: {value}</h3>
      <div id="Calculator-Window">
        <input type="text" id="Calc-Input"/>
        <button class="Calc-Button" onClick={() => setValue(value + 1)}>1</button>
        <button class="Calc-Button" onClick={() => setValue(value + 2)}>2</button>
        <button class="Calc-Button" onClick={() => setValue(value + 3)}>3</button>
        <button class="Calc-Button" onClick={() => setValue(value + 4)}>4</button>
        <button class="Calc-Button" onClick={() => setValue(value + 5)}>5</button>
        <button class="Calc-Button" onClick={() => setValue(value + 6)}>6</button>
        <button class="Calc-Button" onClick={() => setValue(value + 7)}>7</button>
        <button class="Calc-Button" onClick={() => setValue(value + 8)}>8</button>
        <button class="Calc-Button" onClick={() => setValue(value + 9)}>9</button>
        <button class="Calc-Button" onClick={() => setValue(value + -)}>(-)</button>
        <button class="Calc-Button" onClick={() => setValue(value + 0)}>0</button>
        <button class="Calc-Button" onClick={() => setValue(value + 1)}>.</button>
      </div>
    </div>
  );
}
const rootElement = document.getElementById("root");
ReactDOM.render(<CalculatorWindow />, rootElement);
