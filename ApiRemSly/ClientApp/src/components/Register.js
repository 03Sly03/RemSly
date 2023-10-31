import React from 'react';
import { Link } from 'react-router-dom';
import {
    NavLink,
    Container,
    Row,
    Col,
    Card,
    CardBody,
    Button,
    Form,
    FormGroup,
    Label,
    Input,
    //Toast,
    //ToastBody,
    //ToastHeader
} from "reactstrap";

const Register = () => {

    const [lastname, setLastname] = React.useState("");
    const [firstname, setFirstname] = React.useState("");
    const [username, setUsername] = React.useState("");
    const [password, setPassword] = React.useState("");
    const [checkPassword, setCheckPassword] = React.useState("");
    const [isLoggedin, setLoggedin] = React.useState(false);

    const submitHandler = (ev) => {
        ev.preventDefault();
        if (!username || !password || password !== checkPassword) {
            return;
        }
        fetch("https://localhost:7069/api/Authentication/register", {
            method: "POST",
            headers: {
                "Content-Type": "application/json"
            },
            body: JSON.stringify({
                email: username,
                password: password,
                lastname: lastname,
                firstname: firstname
            })
        })
            .then((res) => res.json())
            .then((data) => {
                console.log("RESPONSE from login success ", data);
                setLoggedin(true);
            });

    }

        return (
            <Container>
                { !isLoggedin ? 
                <Row>
                    <Col className="registerCol">
                        <Card className="registerCard">
                            <CardBody>
                                <Form onSubmit={submitHandler}>
                                    <FormGroup className="pb-2 mr-sm-2 mb-sm-0">
                                        <Label for="firstname" className="mr-sm-2">
                                            Prénom
                                        </Label>
                                        <Input
                                            type="text"
                                            name="firstname"
                                            id="firstname"
                                            placeholder="Prénom"
                                            onChange={(ev) => setFirstname(ev.currentTarget.value)}
                                        />
                                    </FormGroup>
                                    <FormGroup className="pb-2 mr-sm-2 mb-sm-0">
                                        <Label for="lastname" className="mr-sm-2">
                                            Nom
                                        </Label>
                                        <Input
                                            type="text"
                                            name="lastname"
                                            id="lastname"
                                            placeholder="Nom"
                                            onChange={(ev) => setLastname(ev.currentTarget.value)}
                                        />
                                    </FormGroup>
                                    <FormGroup className="pb-2 mr-sm-2 mb-sm-0">
                                        <Label for="email" className="mr-sm-2">
                                            Email
                                        </Label>
                                        <Input
                                            type="email"
                                            name="email"
                                            id="email"
                                            placeholder="something@idk.cool"
                                            onChange={(ev) => setUsername(ev.currentTarget.value)}
                                        />
                                    </FormGroup>
                                    <FormGroup>
                                        <Label for="gender">Genre</Label>
                                        <Input type="select" name="gender" id="gender">
                                            <option>Homme</option>
                                            <option>Femme</option>
                                        </Input>
                                    </FormGroup>
                                    <FormGroup className="pb-2 mr-sm-2 mb-sm-0">
                                        <Label for="password" className="mr-sm-2">
                                            Mot de passe
                                        </Label>
                                        <Input
                                            type="password"
                                            name="password"
                                            id="password"
                                            placeholder="don't tell!"
                                            onChange={(ev) => setPassword(ev.currentTarget.value)}
                                        />
                                    </FormGroup>
                                    <FormGroup className="pb-2 mr-sm-2 mb-sm-0">
                                        <Label for="checkPassword" className="mr-sm-2">
                                            Retapez votre mot de passe
                                        </Label>
                                        <Input
                                            type="password"
                                            name="checkPassword"
                                            id="checkPassword"
                                            placeholder="don't tell!"
                                            onChange={(ev) => setCheckPassword(ev.currentTarget.value)}
                                        />
                                    </FormGroup>
                                    <Button type="submit" color="primary">
                                        S'inscrire
                                    </Button>
                                </Form>
                            </CardBody>
                        </Card>
                        <p>Déjà inscris ? <NavLink tag={Link} className="text-dark" to="/login">Connectez-vous ICI</NavLink></p>
                    </Col>
                    </Row>
                    : <p>Vous êtes connecté !</p>}
            </Container>
        );
}

export default Register;