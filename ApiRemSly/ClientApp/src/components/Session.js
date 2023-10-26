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
                src="https://picsum.photos/300/200"
            />
            <CardBody>
                <CardTitle tag="h5">
                    {props.title}
                </CardTitle>
                <CardText>
                    This is some text within a card body.
                </CardText>
            </CardBody>
            <ListGroup flush>
                <ListGroupItem>
                    An item
                </ListGroupItem>
                <ListGroupItem>
                    A second item
                </ListGroupItem>
                <ListGroupItem>
                    And a third item
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