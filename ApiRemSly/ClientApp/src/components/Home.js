import React, { useEffect, useState } from 'react';
import { Link } from 'react-router-dom';
import {
    NavLink,
    Card,
    CardImg,
    CardBody,
    CardTitle,
    CardText
} from "reactstrap";

const Home = () => {

    const [clubs, setClubs] = useState([]);

    useEffect(() => {
        const fetchData = async () => {
            const response = await fetch("https://localhost:7069/api/club");
            const data = await response.json();
            setClubs(data);
        }
        fetchData()
    }, []);


    return (
        <div>
            <h1 className="home-title">Une salle de sport pour être en FoForme !!</h1>
            <div>
                {clubs.map(club => (

                    <NavLink tag={Link} to={`/Club/${club.id}`} state={{ id: club.id }}>
                        <Card className="my-100 home-card">
                            <CardImg
                                alt="Card image cap"
                                src="https://www.toutelanutrition.com/media/cache/terravita_ui_element_anchor_menu_with_image/bannerhubmusculation-64109c1e8b4f3.jpg"
                                className="home-card-img"
                                top
                                width="100%"
                            />
                            <CardBody>
                                <CardTitle tag="h5">
                                    { club.name }
                                </CardTitle>
                                <CardText>
                                    This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.
                                </CardText>
                                <CardText>
                                    <small className="text-muted">
                                        Last updated 3 mins ago
                                    </small>
                                </CardText>
                            </CardBody>
                        </Card>
                    </NavLink>

                ))}
            </div>
        </div>
    );
}

export default Home;
