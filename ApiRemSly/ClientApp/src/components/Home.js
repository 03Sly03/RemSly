import React, { Component } from 'react';
import { Link } from 'react-router-dom';
import {
    NavLink,
    Card,
    CardImg,
    CardBody,
    CardTitle,
    CardText
} from "reactstrap";

export class Home extends Component {
    static displayName = Home.name;
    id = 1;

    render() {
        return (
            <div>
                <h1 className="home-title">Une salle de sport pour être en FoForme !!</h1>
                <div>
                    <NavLink tag={Link} to={`/Club/1`} state={{ id: 1 }}>
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
                                    Anthony Club
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
                    <NavLink tag={Link} to={`/Club/2`} state={{ id: 2 }}>
                        <Card className="my-100 home-card">
                            <CardImg
                                alt="Card image cap"
                                src="https://blogscdn.thehut.net/app/uploads/sites/442/2022/11/john-arano-h4i9G-de7Po-unsplash_1669026578.jpg"
                                className="home-card-img"
                                top
                                width="100%"
                            />
                            <CardBody>
                                <CardTitle tag="h5">
                                    Card Title
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
                    <Card className="my-100 home-card">
                        <CardImg
                            alt="Card image cap"
                            src="https://www.ericfavre.com/lifestyle/wp-content/uploads/2020/05/musculation-pour-qui.jpg"
                            className="home-card-img"
                            top
                            width="100%"
                        />
                        <CardBody>
                            <CardTitle tag="h5">
                                Card Title
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
                    <Card className="my-100 home-card">
                        <CardImg
                            alt="Card image cap"
                            src="https://www.sport-passion.fr/pictures/musculation-femme-FB.jpg"
                            className="home-card-img"
                            top
                            width="100%"
                        />
                        <CardBody>
                            <CardTitle tag="h5">
                                Card Title
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
                    <Card className="my-100 home-card">
                        <CardImg
                            alt="Card image cap"
                            src="https://www.sci-sport.com/style/img/vignette270.jpg"
                            className="home-card-img"
                            top
                            width="100%"
                        />
                        <CardBody>
                            <CardTitle tag="h5">
                                Card Title
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
                </div>
            </div>
        );
    }
}
