import React, { useEffect, useState, createContext } from 'react';
import { Container } from 'reactstrap';
import NavMenu from './NavMenu';
import Footer from './Footer';

const ThemeContext = createContext(null);

const Layout = ({ children }) => {

    const [isLoggedIn, setIsLoggedIn] = useState(false);

    useEffect(() => {
        if (localStorage.getItem('remslytoken')) {
            setIsLoggedIn(true);
        }
    }, [isLoggedIn]);



    return (
        <div>
            <NavMenu isLoggedIn={isLoggedIn} setIsLoggedIn={setIsLoggedIn} />
            <Container>
                <ThemeContext.Provider value={isLoggedIn} >
                    {children}
                </ThemeContext.Provider>
            </Container>
            <Footer />
        </div>
    );
}

export default Layout;
