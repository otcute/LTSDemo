import Header from './component/layout/Header/Header';
import SideBar from './component/layout/Sidebar/SideBar';
import EvaluteStudent from './component/Business/StudentManager/Evalute/EvaluteStudent';
import { useRoutes } from 'react-router-dom';
import StudentDetail from './component/StudentDetail/StudentDetail';
import './App.css';
import Routes from './route/Router';
function App() {
    const element = useRoutes(Routes);
    return (
        <>
            <div className="wrapper">
                <SideBar />
                <div className="main">
                    <Header />
                    <div className="content">{element}</div>
                </div>
            </div>
        </>
    );
}

export default App;
