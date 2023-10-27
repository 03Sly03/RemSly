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

    console.log("les sessions : " + club.sessions)

    return (
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
                            <p>Tel : {club.phoneNumber}</p>
                            <p>Email : {club.email}</p>
                            <p>Adresse : {club.address} - {club.postalCode}</p>
                            <p>Horaires du club : {club.openingHours}</p>
                            <p>{club.isLadiesOnly ? "Ladies only" : ""}</p>
                            <p>{club.is24h ? "24/24" : ""}</p>
                        </CardText>
                    </CardBody>
                </Card>
            </div>

            {club.sessions ?
                <div className="d-flex justify-content-center flex-wrap club-card">
                    {club.sessions.map((session) => (
                        <Session
                            name={session.name}
                            img={session.imageUrl}
                            shedules={session.shedules}
                            capacityMax={session.capacityMax}
                            isComplete={session.isComplete}
                            score={session.score}
                        />
                    ))}
                </div>
                : <p>Pas de sessions pour le moment.</p>}
        </div>
    );
}

export default Club;