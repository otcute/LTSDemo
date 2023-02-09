import NotFound from '../component/404/NotFound';
import EvaluteStudent from '../component/Business/StudentManager/Evalute/EvaluteStudent';
import StudentDetail from '../component/StudentDetail/StudentDetail';

const Routes = [
    {
        path: '/',
        element: <EvaluteStudent />,
    },
    {
        path: '/hocvien/:id',
        element: <StudentDetail />,
    },

    { path: '*', element: <NotFound /> },
];

export default Routes;
