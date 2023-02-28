import './App.css';

import React from 'react';
import { BrowserRouter, Route, Routes } from "react-router-dom";

import SignIn from './components/SignIn';
import SignUp from './components/SignUp';
import Logged from './components/Logged';
import SignOut from './components/SignOut';
import CheckOtp from './components/CheckOtp';

export default function App() {
  return (
    <div className="App">
      <BrowserRouter>
        <Routes>
          <Route path="/" element={<SignIn />} />
          <Route path="/signup" element={<SignUp />} />
          <Route path="/logged" element={<Logged />} />
          <Route path="/signout" element={<SignOut />} />
          <Route path="/checkotp" element={<CheckOtp />} />
        </Routes>
      </BrowserRouter>
    </div>
  );
}
