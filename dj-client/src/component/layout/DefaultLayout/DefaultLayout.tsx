import Header from '../components/Header/Header';
import SideBar from '../components/Sidebar/SideBar';
import TableComponent from '../../Table/TableComponent';
import './DefaultLayout.scss';

function DefaultLayout({ children }: any) {
    return (
        <div className="wrapper">
            <SideBar />
            <div className="main">
                <Header />
                <div className="content">
                    <TableComponent />
                </div>
            </div>
        </div>
    );
}

export default DefaultLayout;
