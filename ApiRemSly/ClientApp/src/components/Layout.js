import React, { useEffect, useState } from 'react';
import { Container } from 'reactstrap';
import NavMenu from './NavMenu';
import Footer from './Footer';
import { ThemeContext } from '../contexts/ThemeContext'


const Layout = ({ children }) => {

    const [isLoggedIn, setIsLoggedIn] = useState(false);
    const [userLogged, setUserLogged] = useState({});

    useEffect(() => {
        if (localStorage.getItem('remslytoken')) {
            setIsLoggedIn(true);
        }
    }, [setIsLoggedIn]);

    return (
        <div>
            <NavMenu isLoggedIn={isLoggedIn} setIsLoggedIn={setIsLoggedIn} userLogged={userLogged} />
            <Container>
                <ThemeContext.Provider value={{ isLoggedIn, setIsLoggedIn, setUserLogged }} >
                    {children}
                </ThemeContext.Provider>
            </Container>
            <Footer />
        </div>
    );
}

export default Layout;
