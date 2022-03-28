import React from 'react';
import { Header } from './components/Header';
import { NavBar } from './components/Navbars';
import { MenuContainer } from './containers/MenuContainer';
import { PanelDashboard } from './containers/PanelDashboard';
import logo from './logo.svg';
import './css/App.css';
import './css/menu.css';
import 'bootstrap/dist/css/bootstrap.css';
import './css/NavBar.css';

function App() {
  return (

    <React.Fragment>
      <NavBar/>
      <MenuContainer/>

    </React.Fragment>
    // <div className="App">
    //   <header className="App-header">
    //     <img src={logo} className="App-logo" alt="logo" />
    //     <p>
    //       Edit <code>src/App.js</code> and save to reload.
    //     </p>
    //     <a
    //       className="App-link"
    //       href="https://reactjs.org"
    //       target="_blank"
    //       rel="noopener noreferrer"
    //     >
    //       Learn React
    //     </a>
    //   </header>
    // </div>
  );
}

export default App;
