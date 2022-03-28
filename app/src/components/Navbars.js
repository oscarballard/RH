import React from "react";
import { Header } from "./Header.js"
import { BsFillBellFill } from "react-icons/bs";
import { UserDropDown } from './userDropDown';

function NavBar(){

    return (
        <React.Fragment>
            <nav className="navbar header d-flex navbar-expand-lg navbar-light bg-light">
                <Header/>
                <div className="collapse navbar-collapse" id="navbarNavDropdown">
                    <form className="form-inline">
                        <input className="form-control mr-sm-2" type="search" placeholder="Search" aria-label="Search"/>
                        <button className="btn btn-outline-success my-2 my-sm-0" type="submit">Search</button>
                    </form>
                    <ul className="navbar-nav">
                        <li className="nav-item">
                            <a className="nav-link" href="#"><BsFillBellFill/></a>
                        </li>
                        <UserDropDown/>
                    </ul>
                </div>
            </nav>
        </React.Fragment>
    )
}

export  { NavBar }