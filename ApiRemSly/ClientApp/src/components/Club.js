import React, { useState, useEffect } from 'react';
import Session from './Session';
import { useLocation } from 'react-router-dom';
import {
    //NavLink,
    Card,
    CardImg,
    CardBody,
    //CardTitle,
    CardText
} from "reactstrap";

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
            {club.length !== 0 ? 
                <div>
                    <div className="d-flex flex-column align-items-center">
                        <h2 className="my-50">{club.name}</h2>
                        <Card className="my-50 home-card">
                            <CardImg
                                alt="Card image cap"
                                src={ club.imageUrl }
                                className="home-card-img"
                                top
                                width="100%"
                            />
                            <CardBody>
                                <CardText>
                                    { club.description }
                                </CardText>
                                <CardText>
                                    Coordonnées de la salle de sport :
                                </CardText>
                                <p>tel : {club.phoneNumber}</p>
                                <p>email : {club.email}</p>
                                <p>adresse : {club.address} - {club.postalCode}</p>
                                <p>horaires du club : {club.openingHours}</p>
                                <p>{club.isLadiesOnly ? "ladies only" : ""}</p>
                                <p>{club.is24h ? "24/24" : ""}</p>
                            </CardBody>
                        </Card>
                    </div>

                    {club.sessions ?
                        <div className="d-flex justify-content-center flex-wrap club-card">
                            {club.sessions.map((session) => (
                                <Session
                                    key={ session.id }
                                    name={session.name}
                                    img={session.imageUrl}
                                    shedules={session.shedules}
                                    capacityMax={session.capacityMax}
                                    isComplete={session.isComplete}
                                    score={session.score}
                                />
                            ))}
                        </div>
                        : <p>Pas de sessions pour le moment.</p>
                    }
                </div>
                :
                <div className="text-center mt-5 display-1">Loading...</div>
            }
        </div>
    );
}

export default Club;