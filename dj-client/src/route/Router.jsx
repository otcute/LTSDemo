import NotFound from '../component/404/NotFound';
import EvaluteStudent from '../component/Business/StudentManager/Evalute/EvaluteStudent';
import StudentDetail from '../component/StudentDetail/StudentDetail';

const Routes = [
    {
        path: '/hocvien',
        element: <EvaluteStudent />,
    },
    {
        path: '/hocvien/hocsinhchitiet/:id',
        element: <StudentDetail />,
    },

    { path: '*', element: <NotFound /> },
];

export default Routes;
