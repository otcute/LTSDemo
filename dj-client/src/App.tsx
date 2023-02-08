import Header from './component/layout/Header/Header';
import SideBar from './component/layout/Sidebar/SideBar';
import EvaluteStudent from './component/Business/StudentManager/Evalute/EvaluteStudent';
import './App.css';
function App() {
    return (
        <>
            <div className="wrapper">
                <SideBar />
                <div className="main">
                    <Header />
                    <div className="content">
                    <EvaluteStudent />
                    </div>
                </div>
            </div>
        </>
    );
}

export default App;
