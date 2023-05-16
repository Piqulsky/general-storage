import { LOCALHOST } from '../constant';

import React, { useState, useEffect } from 'react';
import { Link } from 'react-router-dom';
import axios from 'axios';

export default function SignIn() {
    const [username, setUsername] = useState("");
    const [password, setPassword] = useState("");

    const signIn = () => {
        axios.get(LOCALHOST, {
            params: {
                username: username,
                password: password
            },
            withCredentials: true
        }).then(res => {
            if(res.data == "Logged")
                window.location.href = "/logged";
        }).catch(err => {console.log(err.response)});
    }

    useEffect(() => {
        axios.get(LOCALHOST + "check", {
            withCredentials: true
        }).then(res => {
            if(res.data == "Logged")
                window.location.href = "/logged";
        }).catch(err => {console.log(err.response)});
      }, []);
    
    return (
        <div className="SignIn">
            <h2>Sign In</h2>
            <input type="text" onChange={(event) => setUsername(event.target.value)} /><br />
            <input type="password" onChange={(event) => setPassword(event.target.value)} /><br />
            <button onClick={signIn}>Sign In</button><br />
            <Link to ="/signup">Sign Up</Link>
        </div>
    );
}
