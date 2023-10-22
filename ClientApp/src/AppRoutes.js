import Counter from "./components/Counter";
import  FetchData  from "./components/FetchData";
import { Home } from "./components/Home";
import LoginForm from "./components/Login.jsx";
import RegistrationForm from "./components/Registration.jsx"

const AppRoutes = [
  {
    index: true,
    element: <Home />
  },
  {
    path: '/counter',
    element: <Counter />
  },
  {
    path: '/fetch-data',
    element: <FetchData />
    },

   {
    path: '/login',
    element: <LoginForm/>
  }
  {
    path: '/registration',
    element: <RegistrationForm/>
  }
];

export default AppRoutes;
