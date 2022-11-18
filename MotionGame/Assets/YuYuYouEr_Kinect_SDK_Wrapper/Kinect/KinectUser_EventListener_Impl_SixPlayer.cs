using UnityEngine;
using System.Collections;

public class KinectUser_EventListener_Impl_SixPlayer : KinectUser_EventListener_Impl_default {

	// Use this for initialization
	private KinectUser[] m_kuser_ary = new KinectUser[6];

	KinectUser_EventListener_Impl_SixPlayer()
	{
		for (int i=0; i<m_kuser_ary.Length; ++i)
		{
			m_kuser_ary[i] = null;
		}
	}
	
    public override KinectUser[] getCurrentUser()
    {
		return m_kuser_ary;
    }


	public override void _onKinectUserIn(KinectUser kuser)
	{
		for (int i=0; i<m_kuser_ary.Length; ++i)
		{
			if (null == m_kuser_ary[i])
			{
				m_kuser_ary[i] = kuser;
				break;
			}
		}
	}

	public override void _onKinectUserLeave(KinectUser kuser)
	{
		for (int i = 0; i < m_kuser_ary.Length; ++i)
		{
			if (null != m_kuser_ary[i]
				&& m_kuser_ary[i].m_id == kuser.m_id)
			{
				m_kuser_ary[i] = null;
				break;
			}
		}
	}

	public override void _onKinectUserUpdate(KinectUser kuser)
	{
		for (int i = 0; i < m_kuser_ary.Length; ++i)
		{
			if (null != m_kuser_ary[i]
				&& m_kuser_ary[i].m_id == kuser.m_id)
			{
				m_kuser_ary[i] = kuser;
				break;
			}
		}

	}

}
