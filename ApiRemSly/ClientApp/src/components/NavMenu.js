import React, { useState } from 'react';
import { Collapse, Navbar, NavbarBrand, NavbarToggler, NavItem, NavLink } from 'reactstrap';
import { Link } from 'react-router-dom';
import './NavMenu.css';

const NavMenu = (props) => {

    const [collapsed, setCollapsed] = useState(true);

    const toggleNavbar = () => {
        setCollapsed(!collapsed);
    }

    const disconnect = () => {
        localStorage.removeItem("remslytoken");
        props.setIsLoggedIn(false);
    }

    return (


        <header>
            <Navbar className="navbar-expand-sm navbar-toggleable-sm ng-white border-bottom box-shadow mb-3" container light>
                <NavbarBrand tag={Link} to="/">RemSly Sport</NavbarBrand>
                <NavbarToggler onClick={toggleNavbar} className="mr-2" />
                <Collapse className="d-sm-inline-flex flex-sm-row-reverse" isOpen={!collapsed} navbar>
                    <ul className="navbar-nav flex-grow">
                        <NavItem>
                            {!props.isLoggedIn ?
                                <NavLink tag={Link} className="text-dark" to="/login">Se connecter</NavLink>
                                :
                                <div className="d-flex justify-content-between" style={{width: "400px"} }>
                                    <NavLink tag={Link} className="text-dark" to="/profile">Bienvenue { props.userLogged.firstName } !</NavLink>
                                    <NavLink tag={Link} className="text-dark" to="/#" onClick={disconnect}>Se déconnecter</NavLink>
                                </div>
                            }
                        </NavItem>
                        <NavItem>
                            <p>{ props.dataTest }</p>
                        </NavItem>
                    </ul>
                </Collapse>
            </Navbar>
        </header>
    );
}

export default NavMenu;