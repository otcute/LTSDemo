import Header from './component/layout/Header/Header';
import SideBar from './component/layout/Sidebar/SideBar';
import EvaluteStudent from './component/Business/StudentManager/Evalute/EvaluteStudent';
// import StudentDetail from './component/StudentDetail/StudentDetail';
import './App.css';
function App() {
    // const routes = [
    //     { path: '/', element: <App /> },
    //     {
    //         path: '/evalutestudent',
    //         element: <EvaluteStudent />,
    //         children: [{ path: '/studentdetail', element: <StudentDetail /> }],
    //     },
    // ];
    // const element = useRoutes(routes);
    return (
        <>
            <div className="wrapper">
                <SideBar />
                <div className="main">
                    <Header />
                    <div className="content">
                        <EvaluteStudent />
                        {/* <StudentDetail /> */}
                        {/* {element} */}
                    </div>
                </div>
            </div>
        </>
    );
}

export default App;
