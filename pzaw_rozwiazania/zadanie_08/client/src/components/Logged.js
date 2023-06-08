import { LOCALHOST } from '../constant';

import React, { useState, useEffect } from 'react';
import { Link } from 'react-router-dom';
import axios from 'axios';
import QRCode from "react-qr-code";

export default function Logged() {
    const [articles, setArticles] = useState([]);
    useEffect(() => {
        axios.get(LOCALHOST + "articles", {
            withCredentials: true
        }).then(res => {
            console.log(res.data);
            //setArticles(res.data);
        }).catch(err => console.log(err));
    }, []);

    const [otp, setOtp] = useState(null);
    const generateOtp = () => {
        axios.get(LOCALHOST + "otp", {
            withCredentials: true
        }).then(res => {
            setOtp("http://localhost:3000/checkotp?otp=" + res.data);
            console.log("http://localhost:3000/checkotp?otp=" + res.data);
        }).catch(err => console.log(err));
    }

    return (
        <div className="Logged">
            <h2>Signed In</h2>
            <Link to="/signout">Sign Out</Link><br />
            <button onClick={generateOtp}>Generate OTP password</button>
            <div id='QRotp'>
                {otp != null ? <QRCode size={256} style={{ height: "auto", width: "20%" }} value={otp.toString()} viewBox={`0 0 256 256`} /> : null}
            </div>
            <div>
                <label>Wyświetlana nazwa: </label>
                <input type='text' /><br />
                <label>Treść posta: </label>
                <input type='text' /><br/>
                <button>Dodaj</button>
                <div>
                    {articles.map(x => <div className='Article'>
                        <b>{x.author}: </b><span>{x.content}</span>
                        <div>
                            {/* {x.comments.map(y => <div className='Comment'>
                                <b>{y.commentor}: </b><span>{y.comment}</span>
                            </div>)} */}
                        </div>
                    </div>)}
                </div>
            </div>
        </div>
    );
}
