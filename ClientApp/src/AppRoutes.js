import Counter from "./components/Counter";
import LoginForm from "./components/EmptyTSFile";
import  FetchData  from "./components/FetchData";
import { Home } from "./components/Home";
import LoginForm from "./components/Login"

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
  }{
    path: '/login',
    element: <LoginForm/>
  }
];

export default AppRoutes;
