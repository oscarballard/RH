import React from "react";

function UserDropDown(){

    return (
        <React.Fragment>
            <li className="dropdown navbar-user nav-item dropdown">
					<a href="#" className="nav-link dropdown-toggle" id="navbarDropdownMenuLink" role="button" data-toggle="dropdown" aria-expanded="false">
						<img src="https://developers.google.com/web/images/contributors/no-photo.jpg?hl=es" className="foto_user"/> 
						<span className="d-none d-md-inline">Adam Schwartz</span> <b className="caret"></b>
					</a>
					<div className="dropdown-menu dropdown-menu-user dropdown-menu-right " x-placement="bottom-end" aria-labelledby="navbarDropdownMenuLink">
						<a className="dropdown-item">Edit Profile</a>
						<a className="dropdown-item"><span className="badge badge-danger pull-right">2</span> Inbox</a>
						<a className="dropdown-item">Calendar</a>
						<a className="dropdown-item">Setting</a>
						<div className="dropdown-divider"></div>
						<a className="dropdown-item">Log Out</a>
					</div>
				</li>
        </React.Fragment>
    )
}

export  { UserDropDown }