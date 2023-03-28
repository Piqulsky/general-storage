import './App.css';
import random_data from './api/random_data';

import { useRef, useState } from 'react';

function App() {
  const selectRef = useRef();
  const textRef = useRef();

  const [data, setData] = useState([{}]);

  const handle_button = async () => {
    let newData = [];
    for(let i = 0; i < parseInt(textRef.current.value); i++){
      await random_data[selectRef.current.value]().then((response) => {
          newData.push(response.data)
      })
      .catch((error) => {
          console.log(error);
      });
    }
    setData(newData);
}

  return (
    <div className="App">
      <div>
        <select ref={selectRef}>
          <option value={"users"}>Users</option>
          <option value={"addresses"}>Addresses</option>
          <option value={"banks"}>Banks</option>
          <option value={"appliances"}>Appliances</option>
          <option value={"beers"}>Beers</option>
          <option value={"blood_types"}>Blood Types</option>
          <option value={"credit_cards"}>Credit Cards</option>
        </select>
        <input ref={textRef} />
        <button onClick={handle_button}>Send Request</button>
      </div>
      <table>
        <tbody>
          <tr>{Object.keys(data[0]).map(x => <th>{x}</th>)}</tr>
          {data.map(x => <tr>
            {Object.keys(x).map(y => <td>{x[y].toString()}</td>)}
          </tr>)}
        </tbody>
      </table>
    </div>
  );
}

export default App;
