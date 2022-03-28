import React from "react";
import logo from './../logo.svg';

function Header() {
    
    return (
        <React.Fragment>
			<div className="navbar-header">
					<img src={logo} className="App-logo navbar-brand" alt="logo" />
					<span className="navbar-logo"></span> <b>RH</b> 
			</div>
        </React.Fragment>
    )
}

export  {Header}