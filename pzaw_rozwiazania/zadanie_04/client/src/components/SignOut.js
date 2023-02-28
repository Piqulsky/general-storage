import { LOCALHOST } from '../constant';

import React, { useState, useEffect } from 'react';
import axios from 'axios';

export default function SignOut() {
    useEffect(() => {
        axios.delete(LOCALHOST, {
            withCredentials: true
        }).then(res => window.location.href = "/");
    }, []);

    return (
        <div className="SignOut">
            
        </div>
    );
}
