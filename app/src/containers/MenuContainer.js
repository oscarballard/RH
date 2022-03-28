import React from "react";
import { MenuItem } from "../components/MenuItem"
import {BrowserRouter, Route} from 'react-router-dom';

// import { AiOutlineDashboard } from "react-icons/bs";
import { AiOutlineDashboard, AiFillHome } from "react-icons/ai";

let style ={
    width:'250px'
}

const options = [
    {   id:  1,
        name:'Dashboard',
        icon:'',
        nivel:1,
        selected:false,
        hijos:{}
    },
    {   id:  2,
        name:'Competencias',
        icon:'',
        nivel:1,
        selected:false,
        hijos:{}
    },
    {   id:  3,
        name:'Idiomas',
        icon:'',
        nivel:1,
        selected:false,
        hijos:{}
    },
    {   id:  4,
        name:'Capacitaciones',
        icon:'',
        nivel:1,
        selected:false,
        hijos:{}
    },
    {   id:  5,
        name:'Reclutamiento',
        icon:'',
        nivel:1,
        selected:false,
        hijos:{}
    },
    {   id:  6,
        name:'Reporte',
        icon:'',
        nivel:1,
        selected:false,
        hijos:{}
    }
]

function MenuContainer(){

    return (
        <React.Fragment>
            <aside className="sidebar">
                <div className="d-flex flex-column vh-100 flex-shrink-0 p-3 text-white bg-dark menu" style={style}> 
      
                    <div className="dropdown"> <a href="#" className="d-flex align-items-center text-white text-decoration-none dropdown-toggle" id="dropdownUser1" data-bs-toggle="dropdown" aria-expanded="false"> <img src="https://github.com/mdo.png" alt="" width="32" height="32" className="rounded-circle me-2"/> <strong> John W </strong> </a>
                        <ul className="dropdown-menu dropdown-menu-dark text-small shadow" aria-labelledby="dropdownUser1">
                            <li><a className="dropdown-item" href="#">New project</a></li>
                            <li><a className="dropdown-item" href="#">Settings</a></li>
                            <li><a className="dropdown-item" href="#">Profile</a></li>
                            <li>
                                <hr className="dropdown-divider"/>
                            </li>
                            <li><a className="dropdown-item" href="#">Sign out</a></li>
                        </ul>
                    </div>
                    <hr/>
                    <BrowserRouter>
                        <ul className="nav nav-pills flex-column mb-auto">
                            {options.map(option => (
                                <MenuItem name={option.name} id={option.id}/>
                            ))}

                        </ul>
                    </BrowserRouter>
                </div>
            </aside>
        </React.Fragment>
    )
}

export  { MenuContainer }