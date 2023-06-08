import './App.css';
import React from 'react';

import FormPanel from './components/FormPanel';
import TablePanel from './components/TablePanel';

function App() {
  const [data, setData] = React.useState([]);

  return (
    <div className="App">
      <FormPanel data={data} setData={setData} />
      <TablePanel data={data} />
    </div>
  );
}

export default App;
