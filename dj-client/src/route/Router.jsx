import { BrowserRouter, Route, Routes } from 'react-router-dom';
import EvaluteStudent from '../component/Business/StudentManager/Evalute/EvaluteStudent';
import StudentDetail from '../component/StudentDetail/StudentDetail';
function Router() {
    return (
        <BrowserRouter>
            <Routes>
                <Route index element={<EvaluteStudent />} />
                <Route path="/evalutestudent/:Id" element={<StudentDetail />} />
            </Routes>
        </BrowserRouter>
    );
}

export default Router;
