import Home from "./components/Home";
import Register from "./components/Register";
import Login from "./components/Login";
import Club from "./components/Club";

const AppRoutes = [
    {
        index: true,
        element: <Home />
    },
    {
        path: '/login',
        element: <Login />
    },
    {
        path: '/register',
        element: <Register />
    },
    {
        path: '/club/:id',
        element: <Club />
    },
    {
        path: '*',
        element: <Home />
    }
];

export default AppRoutes;
