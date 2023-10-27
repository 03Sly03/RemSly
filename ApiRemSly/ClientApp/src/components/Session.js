import React from 'react';
import {
    Card,
    CardBody,
    ListGroup,
    ListGroupItem,
    CardTitle,
    CardText,
    CardLink
} from "reactstrap";

const Session = (props) => {

    return (
        <Card
            style={{
                width: '18rem'
            }}
        >
            <img
                alt="Card"
                src={props.img}
            />
            <CardBody>
                <CardTitle tag="h5">
                    {props.name}
                </CardTitle>
                <CardText>
                    Ouverture : {props.shedules}
                </CardText>
            </CardBody>
            <ListGroup flush>
                <ListGroupItem>
                    Capacité maximum : { props.capacityMax }
                </ListGroupItem>
                <ListGroupItem>
                    { props.isComplete ? "Complet" : "Places disponibles" }
                </ListGroupItem>
                <ListGroupItem>
                    note : { props.score }
                </ListGroupItem>
            </ListGroup>
            <CardBody>
                <CardLink href="#">
                    Réserver
                </CardLink>
            </CardBody>
        </Card>
    );
}

export default Session;