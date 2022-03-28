import React from 'react';

function MenuItem(props){
    // <li> <a href="#" className="nav-link text-white"> <i className="fa fa-first-order"></i><span className="ms-2">My Orders</span> </a> </li>
    let active = (props.id == 1 || props.selected)?'active':'text-white';
    
   return (
    <li className="nav-item"> 
        <a href="#" className={"nav-link "+active}  aria-current="page">
            <span className="ms-2">
                {props.name}
            </span> 
        </a> 
    </li>
   );
}

export  {MenuItem};