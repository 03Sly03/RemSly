import React, { useEffect, useState } from 'react';
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

    const [session, setSession] = useState([]);
    const [comments, setComments] = useState([]);

    useEffect(() => {
        const fetchData = async () => {
            const response = await fetch(`https://localhost:7069/api/Session/${props.id}`);
            const data = await response.json();
            setSession(data);
        }
        fetchData()
        const fetchUserComment = async () => {
            const response = await fetch(`https://localhost:7069/api/Commentary`);
            const data = await response.json();
            setComments(data);
        }
        fetchUserComment();
    }, [props]);

    //console.log("les comments : ", comments[0] ? comments[0].user.firstName : "");
    //console.log("le commentaire 3 : ", comments ? comments.find((element) => element.id === 3).user.firstName : "");
    return (
        <Card
            style={{
                width: '18rem'
            }}
        >
            <img
                alt="Card"
                src={session.imageUrl}
            />
            <CardBody>
                <CardTitle tag="h5">
                    {session.name}
                </CardTitle>
                <CardText>
                    Ouverture : {session.schedules}
                </CardText>
            </CardBody>
            <ListGroup flush>
                <ListGroupItem>
                    Capacité maximum : {session.capacityMax }
                </ListGroupItem>
                <ListGroupItem>
                    {session.isComplete ? "Complet" : "Places disponibles" }
                </ListGroupItem>
                <ListGroupItem>
                    note : {session.score }
                </ListGroupItem>
                <ListGroupItem>
                    <p>commentaires :</p>
                    { session.comments && comments ?
                        session.comments.map((comment) => (
                            <div>
                                <small>
                                    - {comments.length !== 0 ? comments.find((element) => element.id === comment.id).user.firstName : "" } -
                                </small>
                                <blockquote>"{comment.content}"</blockquote>
                            </div>
                        ))
                        
                        :
                        <p>Loading...</p>
                    }
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