import React from 'react';
import Session from './Session';
import { useLocation } from 'react-router-dom';

const Club = () => {
    const location = useLocation();
    return (
        <div>
            <div className="d-flex flex-column align-items-center">
                <h2>le club id: {location.state.id}</h2>
                <p>Description du club ...</p>
            </div>

            {location.state.id === 1 ? 
                <div className="d-flex justify-content-center flex-wrap club-card">
                        <Session title="Zoumba" />
                        <Session title="Muscantho" />
                        <Session title="Vélantho" />
                </div>
            : 
                <div className="d-flex justify-content-center flex-wrap club-card">
                        <Session title="Truc" />
                        <Session title="Much" />
                        <Session title="Machin" />
                        <Session title="Bidule" />
                </div>    
            }
        </div>
    );
}

export default Club;