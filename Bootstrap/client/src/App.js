import 'bootstrap/dist/css/bootstrap.css';
import { useRef, useState } from 'react';

function App() {
  const [courses, setCourses] = useState(["Programowanie w C#", "Angular dla początkującyc", "Kurs Django"]);
  const nameRef = useRef();
  const numberRef = useRef();

  const enroll = () => {
    console.log(nameRef.current.value);
    try {
      console.log(courses[numberRef.current.value-1]);
    } catch (error) {
      console.error("Nieprawidłowy numer kursu")
    }
  }

  return (
    <div className="App">
      <h2>Liczba kursów: {courses.length}</h2>
      <ol>
        {courses.map(x => <li>{x}</li>)}
      </ol>
      <form>
        <div className='form-group'>
          <label>Imię i nazwisko:</label>
          <input className='form-control' ref={nameRef} type='text' />
        </div>
        <div className='form-group'>
          <label>Numer kursu:</label>
          <input className='form-control' ref={numberRef} type='number' />
        </div>
        <button type='button' className='btn btn-primary'>Zapisz do kursu</button>
      </form>
    </div>
  );
}

export default App;
