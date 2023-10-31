import React, { useEffect, useState } from 'react';
import { Link } from 'react-router-dom';
import {
    NavLink,
    Card,
    CardImg,
    CardBody,
    CardTitle,
    CardText,
    FormGroup,
    Label,
    Input
} from "reactstrap";




const Home = () => {

    const [clubs, setClubs] = useState([]);
    const [keyword, setKeyword] = useState([]);
    const barStyling = { "borderRadius": "15px", width: "20rem", background: "#F2F1F9", border: "none", padding: "0.5rem" };

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
            <h2>Filtres</h2>
            <FormGroup>
                <Label for="searchBar">Rechercher une salle de sport</Label>
                <Input
                    className="home-search-bar"
                    type="text"
                    name="searchBar"
                    id="searchBar"
                    style={barStyling}
                    key="random1"
                    value={keyword}
                    placeholder={"Chercher"}
                    onChange={(e) => setKeyword(e.target.value)}
                />
            </FormGroup>
            <div className="border border-dark p-3 flex">
                <FormGroup className="Home-select-town w-25">
                    <Label for="selectTown">
                    </Label>
                    <Input
                        id="selectTown"
                        name="selectTown"
                        type="select"
                    >
                        <option>
                            Selectionnez une ville
                        </option>
                        <option>
                            Lille
                        </option>
                        <option>
                            Villeneuve D'Asq
                        </option>
                        <option>
                            Toulouse
                        </option>
                        <option>
                            Amien
                        </option>
                        <option>
                            Berck
                        </option>
                    </Input>
                </FormGroup>
            </div>
            {clubs.length !== 0 ?
                <div>
                    {clubs.map(club => (

                        <NavLink key={club.id} tag={Link} to={`/Club/${club.id}`} state={{ id: club.id }}>
                            <Card className="my-100 home-card">
                                <CardImg
                                    alt="Card image cap"
                                    src={club.imageUrl}
                                    className="home-card-img"
                                    top
                                    width="100%"
                                />
                                <CardBody>
                                    <CardTitle tag="h5">
                                        {club.name}
                                    </CardTitle>
                                    <CardText>
                                        {club.description}
                                    </CardText>
                                    <CardText>
                                        <small className="text-muted">
                                            Visitez cette salle de sport !
                                        </small>
                                    </CardText>
                                </CardBody>
                            </Card>
                        </NavLink>

                    ))}
                </div>
                :
                <div className="text-center mt-5 display-1">Loading...</div>
            }
        </div>
    );
}

export default Home;
