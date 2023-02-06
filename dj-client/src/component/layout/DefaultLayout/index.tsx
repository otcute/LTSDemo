import Header from '../components/Header';
import SideBar from '../components/Sidebar';
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
