import Header from '../components/Header/Header';
import SideBar from '../components/Sidebar/SideBar';
import './DefaultLayout.scss';

function DefaultLayout({ children }: any) {
    return (
        <div className="container">
            <SideBar />
            <div className="main">
                <Header />
                <div className="content">{children}</div>
            </div>
        </div>
    );
}

export default DefaultLayout;
