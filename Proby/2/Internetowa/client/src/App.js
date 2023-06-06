import logo from './logo.svg';
import './App.css';
import axios from 'axios';

function App() {
  let data = [];
  axios.get('http://localhost:8080/egz_ai').then((res) => {
    data = res.data.data;
    console.log(data);
  })
  return (
    <div className="App">
      {data.map(x => {
        <div className="kafel">
          
        </div>
      })}
    </div>
  );
}

export default App;
