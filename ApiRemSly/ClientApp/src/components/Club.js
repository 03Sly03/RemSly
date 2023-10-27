import React, { useState, useEffect } from 'react';
import Session from './Session';
import { useLocation } from 'react-router-dom';

const Club = () => {
    const location = useLocation();

    const [club, setClub] = useState([]);

    useEffect(() => {
        const fetchData = async () => {
            const response = await fetch(`https://localhost:7069/api/club/${location.state.id}`);
            const data = await response.json();
            setClub(data);
        }
        fetchData()
    }, [location]);

    return (
        <div>
            <div className="d-flex flex-column align-items-center">
                <h2>{club.name}</h2>
                <p>Description du club ...</p>
            </div>

            {club.sessions ?
                <div className="d-flex justify-content-center flex-wrap club-card">
                    {club.sessions.map((session) => (
                        <Session title="Zoumba" />

                    ))}
                </div>
                : <p>Pas de sessions pour le moment.</p>}
        </div>
    );
}

export default Club;