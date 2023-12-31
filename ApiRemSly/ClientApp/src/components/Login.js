﻿import React from 'react';
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

const Login = () => {

    const [username, setUsername] = React.useState("");
    const [password, setPassword] = React.useState("");
    //const [isLoggedin, setLoggedin] = React.useState(false);

    const loginHandler = (ev) => {
        ev.preventDefault();
        if (!username || !password) {
            return;
        }

        // email: "eve.holt@reqres.in",
        // password: "cityslicka"
        //fetch("https://reqres.in/api/login", {
        //    method: "POST",
        //    headers: {
        //        "Content-Type": "application/json"
        //    },
        //    body: JSON.stringify({
        //        email: username,
        //        password: password
        //    })
        //})
        //    .then((res) => res.json())
        //    .then((data) => {
        //        console.log("RESPONSE from login success ", data);
        //        setLoggedin(true);
        //    });

        // console.log(username, password);
    };

    return (
        <Container>
            <h1 className="text-center m-b-10">Se connecter</h1>
            <Row>
                <Col>
                    <Card>
                        <CardBody>
                            <Form onSubmit={loginHandler}>
                                <FormGroup className="pb-2 mr-sm-2 mb-sm-0">
                                    <Label for="exampleEmail" className="mr-sm-2">
                                        Email ëtre être conçu
                                    </Label>
                                    <Input
                                        type="email"
                                        name="email"
                                        id="exampleEmail"
                                        placeholder="something@idk.cool"
                                        onChange={(ev) => setUsername(ev.currentTarget.value)}
                                    />
                                </FormGroup>
                                <FormGroup className="pb-2 mr-sm-2 mb-sm-0">
                                    <Label for="examplePassword" className="mr-sm-2">
                                        Mot de passe
                                    </Label>
                                    <Input
                                        type="password"
                                        name="password"
                                        id="examplePassword"
                                        placeholder="don't tell!"
                                        onChange={(ev) => setPassword(ev.currentTarget.value)}
                                    />
                                </FormGroup>
                                <Button type="submit" color="primary">
                                    Se connecter
                                </Button>
                            </Form>
                        </CardBody>
                    </Card>
                    <p>Pas encore inscris ? <NavLink tag={Link} className="text-dark" to="/register">C'est par ICI</NavLink></p>
                    {/*<Card className="mt-5">*/}
                        {/*<CardBody>*/}
                        {/*    {isLoggedin && (*/}
                        {/*        <>*/}
                        {/*            <div>User is logged in on the system.</div>*/}
                        {/*            <div className="p-3 bg-success my-2 rounded">*/}
                        {/*                <Toast>*/}
                        {/*                    <ToastHeader>Reactstrap</ToastHeader>*/}
                        {/*                    <ToastBody>*/}
                        {/*                        This is a toast on a success background — check it out!*/}
                        {/*                    </ToastBody>*/}
                        {/*                </Toast>*/}
                        {/*            </div>*/}
                        {/*        </>*/}
                        {/*    )}*/}

                        {/*    {!isLoggedin && (*/}
                        {/*        <div>*/}
                        {/*            Please login with your credentials. <br /> Look at*/}
                        {/*            https://reqres.in/ for api help.*/}
                        {/*        </div>*/}
                        {/*    )}*/}
                        {/*</CardBody>*/}
                    {/*</Card>*/}
                </Col>
            </Row>
        </Container>
    );

}

export default Login;