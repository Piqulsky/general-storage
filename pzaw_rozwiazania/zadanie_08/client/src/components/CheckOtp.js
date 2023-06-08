import { LOCALHOST } from '../constant';

import React, { useState, useEffect } from 'react';
import axios from 'axios';

export default function CheckOtp() {
    useEffect(() => {
        const queryParams = new URLSearchParams(window.location.search);
        axios.get(LOCALHOST + "otp/check", {
            params: {
                otp: queryParams.get("otp")
            },
            withCredentials: true
        }).then(res => {
            console.log(res);
            window.location.href = "/logged";
        }).catch(err => console.log(err));
    }, []);

    return (
        <div className="CheckOtp"></div>
    );
}
