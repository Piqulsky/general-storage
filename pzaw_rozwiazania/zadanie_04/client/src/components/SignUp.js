import { LOCALHOST } from '../constant';

import React, { useState } from 'react';
import { Link } from 'react-router-dom';
import axios from 'axios';

export default function SignUp() {
    const [username, setUsername] = useState("");
    const [password, setPassword] = useState("");

    const signUp = () => {
        axios.post(LOCALHOST, {
            username: username,
            password: password
        }, {
            withCredentials: true
        }).then(res => {
            if(res.data == "Registered")
                window.location.href = "/logged";
        }).catch(err => {console.log(err.response)});
    }
    return (
        <div className="SignUp">
            <h2>Sign Up</h2>
            <input type="text" onChange={(event) => setUsername(event.target.value)} /><br />
            <input type="password" onChange={(event) => setPassword(event.target.value)} /><br />
            <button onClick={signUp}>Sign Up</button><br />
            <Link to ="/">Sign In</Link>
        </div>
    );
}
