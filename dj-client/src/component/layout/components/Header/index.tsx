import './Header.scss';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faBarsStaggered, faBell, faGear } from '@fortawesome/free-solid-svg-icons';
import { useProSidebar } from 'react-pro-sidebar';

function Header() {
    const { collapseSidebar } = useProSidebar();
    return (
        <div className="header">
            <div className="header_left">
                <button className="header_icon" onClick={() => collapseSidebar()}>
                    <FontAwesomeIcon icon={faBarsStaggered} />
                </button>
            </div>
            <div className="header_right">
                <button className="header_icon">
                    <FontAwesomeIcon icon={faBell} />
                </button>
                <button className="header_icon">
                    <FontAwesomeIcon icon={faGear} />
                </button>
                <div className="user_card">
                    <div className="avatar">
                        <img src="https://elstar.themenate.net/img/avatars/thumb-1.jpg" alt="" />
                    </div>
                    <div>
                        <div className="role">Admin</div>
                        <div className="user_name">Nguyễn Quang Anh</div>
                    </div>
                </div>
            </div>
        </div>
    );
}

export default Header;
